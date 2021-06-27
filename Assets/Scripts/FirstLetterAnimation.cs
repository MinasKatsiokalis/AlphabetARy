using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstLetterAnimation : MonoBehaviour
{
    [SerializeField]
    Vector3 positionToMoveTo;
    Vector3 startPosition;
    void Start() {
        startPosition = transform.localPosition;
    }

    void Update()
    {   if(gameObject.GetComponentInParent<Transform>().localScale.x >= 0.1566)
        {
            if (transform.localPosition == startPosition)
                StartCoroutine(LerpPosition(positionToMoveTo, 1));
            if (transform.localPosition == positionToMoveTo)
                StartCoroutine(LerpPosition(startPosition, 1));
        } 
    }

    IEnumerator LerpPosition(Vector3 targetPosition, float duration)
    {
        float time = 0;
        Vector3 startPosition = transform.localPosition;

        while (time < duration)
        {
            transform.localPosition = Vector3.Lerp(startPosition, targetPosition, time / duration);
            time += Time.deltaTime;
            yield return null;
        }
        transform.localPosition = targetPosition;
    }
}
