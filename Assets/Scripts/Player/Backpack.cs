using UnityEngine;

namespace Player
{
    public class Backpack : MonoBehaviour
    {
        [SerializeField] private GameObject _map;
        [SerializeField] private GameObject _droppableMap;
        [SerializeField] private Transform _spawnPoint;

        private void Update()
        {
            Drop();
        }

        public void Grab(GameObject grabableMap)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                Destroy(grabableMap);
                _map.SetActive(true);
            }          
        }

        public void Drop()
        {
            if (Input.GetKeyDown(KeyCode.G) && _map.activeSelf)
            {
                _map.SetActive(false);
                Instantiate(_droppableMap, _spawnPoint.position, Quaternion.identity);
            }          
        }
    }
}
