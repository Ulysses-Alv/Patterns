using UnityEngine;
public class Facade : MonoBehaviour 
{
    [SerializeField] FinalConsumer finalConsumer;
    public void DoOne()
    {
        finalConsumer.ActionOne();
    }
    public void DoTwo()
    {
        finalConsumer.ActionTwo();
    }
}