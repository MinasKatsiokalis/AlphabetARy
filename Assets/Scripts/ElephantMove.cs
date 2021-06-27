using System.Collections;
using UnityEngine;

public class ElephantMove : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]
    Vector3 positionToMoveTo;
    [SerializeField]
    float duration;
    void Start()
    {
        StartCoroutine(LerpPosition(positionToMoveTo, duration));
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
