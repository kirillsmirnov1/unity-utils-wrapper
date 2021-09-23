using System;
using UnityEngine;
using UnityUtils;

namespace DefaultNamespace
{
    public class ObservableTest : MonoBehaviour
    {
        [SerializeField] private Observable<int> intObs;
        [SerializeField] private Observable<string> stringObs;
        [SerializeField] private Observable<Person[]> personsObservable;
        [SerializeField] private Observable<Person>[] personObservables;
        
        [Serializable]
        public class Person
        {
            public bool alive;
            public string name;
            public DateTime dateOfBirth;
            public string favouriteIceCreamFlavor;
        }
    }
}