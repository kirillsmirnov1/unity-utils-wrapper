using System;
using System.Collections;
using UnityEngine;
using Random = UnityEngine.Random;

namespace Test.Log
{
    public class ShitPostToLog : MonoBehaviour
    {
        private void Start()
        {
            StartCoroutine(Shitpost());
        }

        private IEnumerator Shitpost()
        {
            while (true)
            {
                switch ((LogType)Random.Range(0, 4))
                {
                    case LogType.Error:
                        Debug.LogError("Error!!");
                        break;
                    case LogType.Assert:
                        Debug.LogAssertion("Assert!");
                        break;
                    case LogType.Warning:
                        Debug.LogWarning("WAAAAAARNING");
                        break;
                    case LogType.Log:
                        Debug.Log("sup");
                        break;
                    case LogType.Exception:
                        Debug.LogException(new Exception("Exception"));
                        break;
                }
                yield return new WaitForSeconds(Random.Range(.5f, 1.5f));
            }
        }
    }
}
