using System;
using UnityEngine;

namespace Player
{
    public class PlayerMovement : MonoBehaviour
    {
        [SerializeField] private float speed = 10f;
        [SerializeField] private float angularSpeed = 10f;


        private void FixedUpdate()
        {
            transform.position += Input.GetAxis("Vertical") * transform.right.normalized * speed * Time.fixedDeltaTime;
            transform.Rotate(0, 0, -1 * Input.GetAxis("Horizontal") * angularSpeed * Time.fixedDeltaTime);
        }
    }
}
