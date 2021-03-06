using System.Collections.Generic;
using UnityEngine;

namespace MathCorrectMovenment
{
    public class PhysicsMovement : MonoBehaviour
    {
        public float MinGroundNormalY = 0.65f;
        public float GravityModifier = 1f;
        public Vector2 Velocity;
        public LayerMask LayerMask;

        private Vector2 targetVelocity;
        private bool grounded;
        private Vector2 groundNormal;
        private Rigidbody2D rigidbody2D;
        private ContactFilter2D contactFilter2D;
        private RaycastHit2D[] hitBuffer = new RaycastHit2D[16];
        private List<RaycastHit2D> hitBufferList = new List<RaycastHit2D>(16);
        private const float minMoveDistance = 0.001f;
        private const float shellRadius = 0.01f;

        private void OnEnable()
        {
            rigidbody2D = GetComponent<Rigidbody2D>();
        }

        void Start()
        {
            contactFilter2D.useTriggers = false;
            contactFilter2D.SetLayerMask(LayerMask);
            contactFilter2D.useLayerMask = true;
        }

        void Update()
        {
            targetVelocity = new Vector2(Input.GetAxis("Horizontal"), 0);
            if (Input.GetKey(KeyCode.Space) && grounded)
                Velocity.y = 5;
        }

        private void FixedUpdate()
        {
            Velocity += GravityModifier * Physics2D.gravity * Time.deltaTime;
            Velocity.x = targetVelocity.x;

            grounded = false;

            Vector2 deltaPosition = Velocity * Time.deltaTime;
            Vector2 moveAlongGround = new Vector2(groundNormal.y, -groundNormal.x);
            Vector2 move = moveAlongGround * deltaPosition.x;

            Movement(move, false);
            move = Vector2.up * deltaPosition.y;
            Movement(move, true);
        }

        void Movement(Vector2 move, bool yMovement)
        {
            float distance = move.magnitude;
            if (distance > minMoveDistance)
            {
                int count = rigidbody2D.Cast(move, contactFilter2D, hitBuffer, distance + shellRadius);
                hitBufferList.Clear();
                for (int i = 0; i < count; i++)
                {
                    hitBufferList.Add(hitBuffer[i]);
                }
                for (int i = 0; i < hitBufferList.Count; i++)
                {
                    Vector2 currentNormal = hitBufferList[i].normal;
                    if (currentNormal.y > MinGroundNormalY)
                    {
                        grounded = true;
                        if (yMovement)
                        {
                            groundNormal = currentNormal;
                            currentNormal.x = 0;
                        }
                    }
                    float projection = Vector2.Dot(Velocity, currentNormal);
                    if (projection < 0)
                    {
                        Velocity = Velocity - projection * currentNormal;
                    }
                    float modifiedDistance = hitBufferList[i].distance - shellRadius;
                    distance = modifiedDistance < distance ? modifiedDistance : distance;
                }
            }
            rigidbody2D.position = rigidbody2D.position + move.normalized * distance;
        }
    }
}
