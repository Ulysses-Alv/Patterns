using UnityEngine;
using UniRx;

public class Enemy : MonoBehaviour
{
    public ReactiveProperty<int> hp = new ReactiveProperty<int>(100);
}