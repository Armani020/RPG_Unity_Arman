using UnityEngine;

namespace Traps
{
    public class ActivationSpearLauncher : MonoBehaviour
    {
        // Start is called before the first frame update
        void Start()
        {
        
        }

        // Update is called once per frame
        void Update()
        {
        
        }
    
        private void OnTriggerStay(Collider other)
        {
            if (other.CompareTag("Player"))
            {
                transform.GetComponent<Animator>().Play("Spear_Play");
            }
        }
    }
}
