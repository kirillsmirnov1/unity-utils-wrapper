using UnityEngine;
using UnityUtils.Attributes;

public class NamedArrayTest : MonoBehaviour
{
    [NamedArray(typeof(Fruits))] public int[] fruitCount;
    private enum Fruits { Apple, Banana, Coconut, Duran }
}