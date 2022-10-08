using UnityEngine;

namespace GameFolders.Scripts.Moments
{
    public class Jump : MonoBehaviour
    {
        [SerializeField] float jumpForce = 300f;

        public void JumpAction(Rigidbody2D rb2D)
        {
            rb2D.AddForce(Vector2.up * jumpForce);
        }
    }
}
