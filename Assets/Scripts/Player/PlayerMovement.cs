using UnityEngine;

namespace Player
{
    public class PlayerMovement : MonoBehaviour
    {
        [SerializeField] private float _moveSpeed;
        


        void FixedUpdate()
        {
            Move();
        }

        private void Move()
        {
            float moveHorizontal = Input.GetAxis("Horizontal");
            transform.position += new Vector3(moveHorizontal, 0, 0) * Time.deltaTime * _moveSpeed;

            float moveVertical = Input.GetAxis("Vertical");
            transform.position += new Vector3(0, moveVertical, 0) * Time.deltaTime * _moveSpeed;
        }
        
    }
}