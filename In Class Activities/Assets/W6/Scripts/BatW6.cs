using TMPro;
using UnityEngine;

// Write the BatW6 class here.
public class BatW6 : MonoBehaviour
{
    [SerializeField] private float _speed;
    private Transform _playerPosition;

    void Start()
    {
        enabled = false;
    }
    public void Chase(Transform playerPosition)
    {
        enabled = true;
        _playerPosition = playerPosition;
    
    }

    public void Stop()
    {
        enabled = false;
    }
    
    private void Update()
    {
        Debug.Log(_playerPosition.position);
        transform.position = Vector3.MoveTowards(transform.position, _playerPosition.position, _speed * Time.deltaTime);
      
    }
}
