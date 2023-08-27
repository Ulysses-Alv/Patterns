using UnityEngine;
using UniRx;

namespace ObserverPattern
{
    public class Enemy : MonoBehaviour
    {
        public ReactiveProperty<int> hp = new ReactiveProperty<int>(100);
    }
}