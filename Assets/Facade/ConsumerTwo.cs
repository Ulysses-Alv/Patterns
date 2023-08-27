using UnityEngine;

namespace FacadePattern
{
    public class ConsumerTwo : MonoBehaviour
    {
        [SerializeField] Facade facade;

        void ExampleTwo()
        {
            facade.DoTwo();
        }
    }
}