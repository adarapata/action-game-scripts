using UnityEngine;
using System.Collections;
using UniRx;

namespace Game.Base {
    public class Life
    {
        public IObservable<int> lifeOverStream { get; private set; }
        public ReactiveProperty<int> currentPoint { get; private set; }

        public Life (int initialPoint)
        {
            currentPoint = new ReactiveProperty<int>(initialPoint);
            lifeOverStream = currentPoint.Where(x => x <= 0).Take(1).AsObservable();
        }

        public void Damage(int point)
        {
            currentPoint.Value -= point;
        }
    }
}