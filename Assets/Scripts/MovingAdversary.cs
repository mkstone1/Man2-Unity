using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingAdversary : MonoBehaviour
{
    public Vector3 pointA;
    public Vector3 pointB;
    public float speed = 1.0f;

    IEnumerator Start()
    {
        while (true)
        {
            yield return StartCoroutine(MoveObject(pointA, pointB, speed));
            yield return StartCoroutine(MoveObject(pointB, pointA, speed));
        }
    }

    IEnumerator MoveObject(Vector3 start, Vector3 end, float speed)
    {
        float step = speed * Time.deltaTime;
        float journeyLength = Vector3.Distance(start, end);
        float startTime = Time.time;

        float distanceCovered = (Time.time - startTime) * speed;
        float fractionOfJourney = distanceCovered / journeyLength;

        while (fractionOfJourney < 1f)
        {
            fractionOfJourney = (Time.time - startTime) * speed / journeyLength;
            transform.position = Vector3.Lerp(start, end, fractionOfJourney);
            yield return null;
        }
    }
}