using UnityEngine;
namespace FacadePattern
{
    public class Facade : MonoBehaviour
    {
        [SerializeField] Consumible finalConsumer;
        public void DoOne()
        {
            finalConsumer.ActionOne();
        }
        public void DoTwo()
        {
            finalConsumer.ActionTwo();
        }
    }
}
