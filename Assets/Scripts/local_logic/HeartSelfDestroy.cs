using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeartSelfDestroy : MonoBehaviour
{
    public void OnAnimationCompleted()
    {
        Destroy(gameObject);
    }
}
