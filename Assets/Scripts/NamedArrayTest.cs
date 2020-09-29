using UnityEngine;
using UnityUtils.Attributes;

public class NamedArrayTest : MonoBehaviour
{
    [NamedArray(typeof(SomeEnum))] public int[] data;
    private enum SomeEnum { A, B, C, D }
}