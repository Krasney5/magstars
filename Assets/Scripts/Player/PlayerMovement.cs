using UnityEngine;

namespace Player
{
    public class PlayerMovement : MonoBehaviour
    {
        [SerializeField] private float _moveSpeed;



        private void Update()
        {
            Move();
        }

        private void Move()
        {
            var movement = Input.GetAxisRaw("Horizontal");
            transform.position += new Vector3(movement, 0f) * _moveSpeed * Time.deltaTime;
        }
        
    }
}