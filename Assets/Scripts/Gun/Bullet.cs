using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Gun
{
    public class Bullet : MonoBehaviour
    {
        [SerializeField] private float _speed;
        [SerializeField] private float _lifeTime;
        [SerializeField] private float _distance;
        
        private void Update()
        {
            Fire();
        }

        private void Start()
        {
            Destroy(gameObject, _lifeTime);
        }

        private void Fire()
        {
            var hitInfo = Physics2D.Raycast(transform.position, transform.right, _distance);
            if (hitInfo.collider != null)
            {
                Destroy(gameObject);
                
            }
            transform.Translate(Vector2.right * _speed * Time.deltaTime);
        }

        private void OnDrawGizmosSelected()
        {
            Gizmos.color = Color.yellow;
            Gizmos.DrawRay(transform.position, transform.right * _distance);
        }
    }
}