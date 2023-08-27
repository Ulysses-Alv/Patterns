using UnityEngine;

namespace FacadePattern
{
    public class ConsumerOne : MonoBehaviour
    {
        [SerializeField] Facade facade;

        void ExampleOne()
        {
            facade.DoOne();
        }
    }
}