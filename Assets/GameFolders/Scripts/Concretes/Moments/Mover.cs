using UnityEngine;
using GameFolders.Scripts.Concretes.Enums;
using UnityEngine.Serialization;

namespace GameFolders.Scripts.Moments
{
    [RequireComponent(typeof(Rigidbody2D))]
    public class Mover : MonoBehaviour
    {
        [SerializeField] private float moveSpeed = 5f;
        [SerializeField] private DirectionEnum direction;


        private Rigidbody2D _rigidbody2D;

        private void Awake()
        {
            _rigidbody2D = GetComponent<Rigidbody2D>();
        }

        private void Start()
        {
            _rigidbody2D.velocity = SelectNewDirecrion() * moveSpeed;
        }

        private Vector2 SelectNewDirecrion()
        {
            Vector2 selectedDirection;
            selectedDirection = direction == DirectionEnum.Left ? Vector2.left : Vector2.right;

            return selectedDirection;
        }
    }
}
