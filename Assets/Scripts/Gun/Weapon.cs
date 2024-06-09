using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Gun
{
    public class Weapon : MonoBehaviour
    {
        [SerializeField] private Bullet _bullet;
        [SerializeField] private Transform _shootPoint;

        private void Update()
        {
            Shoot();
        }

        private void Shoot()
        {
            if (Input.GetMouseButtonDown(0))
            {
                Instantiate(_bullet, _shootPoint.position, transform.rotation);
            }
        }
    }
}
