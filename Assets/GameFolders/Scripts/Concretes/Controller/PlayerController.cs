using GameFolders.Scripts.Moments;
using UnityEngine;

namespace GameFolders.Scripts.Controller
{
    public class PlayerController : MonoBehaviour
    {
        private Rigidbody2D _rigidbody2D;
        private Jump _jump;
        LaunchProjectile _launchProjectile;
        AudioSource _audioSource;
        private PcInputController _input;


        private bool _isLeftMouseClicked;
        private bool _isRightMouseClicked;

        private void Awake()
        {
            _rigidbody2D = GetComponent<Rigidbody2D>();
            _jump = GetComponent<Jump>();
            _launchProjectile = GetComponent<LaunchProjectile>();
            _input = GetComponent<PcInputController>();
            _audioSource = GetComponent<AudioSource>();
        }


        private void Update()
        {
            if (_input.LeftMouseClickDown) _isLeftMouseClicked = true;

            if (_input.RightMouseClickDown) _isRightMouseClicked = true;
        }

        private void FixedUpdate()
        {
            if (_isLeftMouseClicked)
            {
                _jump.JumpAction(_rigidbody2D);
                _audioSource.Play();
                _isLeftMouseClicked = false;
            }

            if (_isRightMouseClicked)
            {
                _launchProjectile.LaunchAction();
                _isRightMouseClicked = false;
            }
        }
    }
}
