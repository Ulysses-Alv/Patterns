using UnityEngine;

public class ConsumerTwo : MonoBehaviour
{
    [SerializeField] Facade facade;

    void ExampleTwo()
    {
        facade.DoTwo();
    }
}
