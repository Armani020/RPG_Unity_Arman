using UnityEngine;

namespace Traps
{
    public class ActivationFloorSpikes : MonoBehaviour
    {
        private void OnTriggerStay(Collider other)
        {
            if (other.CompareTag("Player"))
            {
                transform.GetComponent<Animator>().Play("Trap_Play");
            }
        }
    }
}
