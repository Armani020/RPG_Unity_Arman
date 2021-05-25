using UnityEngine;

namespace Traps
{
    public class ActivationSpearLauncher : MonoBehaviour
    {
        private void OnTriggerStay(Collider other)
        {
            if (other.CompareTag("Player"))
            {
                transform.GetComponent<Animator>().Play("Spear_Play");
            }
        }
    }
}
