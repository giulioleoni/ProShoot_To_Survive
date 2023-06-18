using System;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    [Header("Player variables")]
    [SerializeField] private float playerMoveSpeed = 6f; // Speed at which the player moves.
    [SerializeField] private float playerRotationSpeed = 6f; // Speed at which the player moves.
    [SerializeField] private float jumpForce = 5f; // Force applied when the player jumps.
    private CharacterController charController; // Reference to the CharacterController component for player movement.
    private Animator animator; // Reference to the Animator component for controlling animations.
    private float gravityVelocity; // Player's current velocity.
    private bool isJumping; // Flag indicating if the player is currently jumping.
    [SerializeField] float damageDealt;

    [Header("\nBullet reference variables")]
    [SerializeField] private GameObject Bullet; // Reference to Bullet prefab.
    [SerializeField] private Transform BulletSpawn; // Reference to BulletSpown transform.
    [SerializeField] private Transform CentreCameraTarget; // Reference to the transform of an EmptyObject located in the center of the camera frame. 

    [Header("PowerUp variables")]
    public float hp;
    public float armour;
    public int grenades;

    [SerializeField] GameObject grenadePrefab;
    [SerializeField] Transform grenadeSpawnPoint;

    [Header("Homing variables")]
    private bool activeHoming;
    [SerializeField] float homingTimer;
    [SerializeField] float homingTime;
    [SerializeField] float viewRadius = 300;
    [SerializeField] LayerMask enemyMask;
    [SerializeField] LayerMask obstacleMask;
    [SerializeField] float rotSpeed;
    [SerializeField] float angleOfVision = 180;

    [Header("Camera reference variables")]
    [HideInInspector] public Transform cam;

    //Input system controller
    public InputSysController InputsController { get; private set; }

    [SerializeField] LayerMask aimMask;

    [SerializeField] SkinnedMeshRenderer smr;
    [SerializeField] Material normalMaterial;
    [SerializeField] Material homingMaterial;


    private void Awake()
    {
        //inputSysController = new InputSysController();

        //animator = GetComponent<Animator>(); // Get the Animator component attached to the same GameObject.
        //cam = Camera.main.transform;
    }

    private void Start()
    {
        InputsController = new InputSysController();

        animator = GetComponent<Animator>(); // Get the Animator component attached to the same GameObject.
        charController = GetComponent<CharacterController>();
        cam = Camera.main.transform;
    }

    private void Update()
    {
        updateStats();

        Jump();
        ApplyGravity();
        CheckIsOnGround();

        ThrowGrenade();
        Shoot();

        MovePlayer();

        if (activeHoming)
        {
            homingTimer -= Time.deltaTime;

            if (homingTimer <= 0)
            {
                activeHoming = false;
                smr.material = normalMaterial;
            }
        }
        
    }

    public void ReceiveDamage(float damage)
    {
        if (armour > 0)
        {
            armour -= damage;
            UpdateArmourText();
        }
        else
        {
            hp -= damage;
            UpdateHPText();
        }
    }

    public void ActivateHoming()
    {
        activeHoming = true;
        homingTimer = homingTime;
        smr.material = homingMaterial;
    }

    public void CheckIsOnGround()
    {
        if (charController.isGrounded && gravityVelocity < 0f)
        {
            gravityVelocity = -0.1f; // Ensure a small negative value to stick the player to the ground.

            if (isJumping)
            {
                isJumping = false;
                animator.SetBool("Jump_b", false); // Set the "Jump_b" parameter in the animator to false.
            }
        }
    }

    private void MovePlayer()
    {
        Vector3 moveDir = InputsController.GetInputValue<Vector2>("MoveDir"); // gets normalized input move directions from the input system.
        Vector3 playerVelocity = Vector3.zero;

        playerVelocity += cam.transform.right * moveDir.x * playerMoveSpeed;
        playerVelocity += cam.transform.forward * moveDir.y * playerMoveSpeed;
        playerVelocity *= 0.5f;
        playerVelocity.y = 0;

        if (playerVelocity != Vector3.zero)
        {
            transform.forward = Vector3.Lerp(transform.forward, playerVelocity, playerRotationSpeed * Time.deltaTime);
        }

        float idleMoveBlender = moveDir.magnitude; // Calculate the magnitude of the movement vector.
        animator.SetFloat("Speed_f", idleMoveBlender); // Set the "Speed_f" parameter in the animator based on the current speed.
        animator.SetBool("Static_b", !InputsController.OnInputTrigger("MoveDir")); // Set the "Static_b" parameter in the animator based on the movement state.

        playerVelocity.y = gravityVelocity;

        charController.Move(playerVelocity * Time.deltaTime);
    }

    private void ThrowGrenade()
    {
        if (InputsController.OnInputTrigger("ThrowGrenade"))
        {
            GameObject grenade = Instantiate(grenadePrefab, grenadeSpawnPoint.position, grenadeSpawnPoint.rotation);
            grenade.GetComponent<Grenade>().Throw(transform.forward);
        }
    }

    private void Shoot()
    {
        if (!InputsController.OnInputTrigger("Shoot"))
        {
            return;
        }

        if (!activeHoming)
        {
            Ray rayToCenter = new Ray(cam.position, cam.forward);

            Vector3 shootDir = Vector3.zero;

            if (Physics.Raycast(rayToCenter, out RaycastHit target, Mathf.Infinity, aimMask))
            {
                shootDir = (target.point - BulletSpawn.position).normalized;
            }
            else
            {
                shootDir = ((cam.position + cam.forward * 100) - BulletSpawn.position).normalized;
            }

            GameObject bullet = Instantiate(Bullet, BulletSpawn.position, BulletSpawn.rotation); // Instantiate the bullet
            

            bullet.GetComponent<BulletLogic>().dir = shootDir; // Set the bullet direction
            bullet.GetComponent<BulletLogic>().DamageDealt = damageDealt;
        }
        else
        {
            GameObject go = Instantiate(Bullet, BulletSpawn.position, BulletSpawn.rotation); // Instantiate the bullet
            BulletLogic bullet = go.GetComponent<BulletLogic>();
            bullet.target = SetTarget();
            bullet.DamageDealt = damageDealt;
            StartCoroutine(bullet.WaitToEnableHoming());

        }
    }

    public void Jump()
    {
        if (charController.isGrounded && InputsController.OnInputTrigger("Jump"))
        {
            gravityVelocity = jumpForce; // Apply the jump force to the player's velocity.
            isJumping = true; // Set the jumping flag to true.
            animator.SetBool("Jump_b", true); // Set the "Jump_b" parameter in the animator to true.
            animator.SetBool("Jump_b", false); // Set the "Jump_b" parameter in the animator to false in order to prevent a doublejump.

        }
    }

    private void ApplyGravity()
    {
        gravityVelocity += Physics.gravity.y * Time.deltaTime; // Apply gravity to the player's velocity.
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("PowerUp"))
        {
            other.GetComponent<PowerUp>().PickUp(gameObject);
        }
    }

    internal void UpdateHPText()
    {
        throw new NotImplementedException();
    }

    internal void UpdateArmourText()
    {
        throw new NotImplementedException();
    }

    private Transform SetTarget()
    {
        Transform target = null;
        Collider[] enemyTargets = Physics.OverlapSphere(transform.position, viewRadius, enemyMask);

        if (enemyTargets.Length > 0)
        {
            Transform nextTarget = null;
            Vector3 lowestDist = Vector3.zero;

            for (int i = 0; i < enemyTargets.Length; i++)
            {
                Transform possibleTarget = enemyTargets[i].transform;
                Vector3 distToTarget = possibleTarget.position - transform.position;
                float angleToTarget = Vector3.Angle(transform.forward, distToTarget.normalized);
                // check if enemy is within angle of vision
                if (angleToTarget < angleOfVision * 0.5f)
                {
                    // check if enemy is NOT behind a wall
                    if (!Physics.Raycast(transform.position, distToTarget.normalized, distToTarget.magnitude, obstacleMask))
                    {
                        if (nextTarget == null)
                        {
                            lowestDist = distToTarget;
                            nextTarget = possibleTarget.GetChild(2);
                        }
                        else if (distToTarget.sqrMagnitude < lowestDist.sqrMagnitude)
                        {
                            lowestDist = distToTarget;
                            nextTarget = possibleTarget.GetChild(2);
                        }
                    }
                }
            }
            Debug.Log(nextTarget);
            target = nextTarget;
        }

        return target;
    }

    void updateStats()
    {
        //damageDealt = PlayerLogic.Instance.damage;
        //playerMoveSpeed = PlayerLogic.Instance.speed;
    }

    private void OnDestroy()
    {
        SceneManager.LoadScene(2);
    }

}