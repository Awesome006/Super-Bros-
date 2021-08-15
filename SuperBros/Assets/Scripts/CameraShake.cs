using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraShake : MonoBehaviour
{
    // Start is called before the first frame update
    public IEnumerator Shake(float duration, float maginitude)
    {
        Vector3 orignalpos = this.transform.localPosition;
        float elapsed = 0.0f;
        while (elapsed < duration)
        {
            float x = UnityEngine.Random.Range(-1f, 1f) * maginitude;
            float y = UnityEngine.Random.Range(+1f, -1f) * maginitude;
            transform.localPosition = new Vector3(x, y, orignalpos.z);
            elapsed = +Time.deltaTime;
            yield return null;

        }
        transform.localPosition = orignalpos;


    }
}

    
