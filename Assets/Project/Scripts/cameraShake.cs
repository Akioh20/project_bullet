using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*Codigo antiguo --> no sabemos si lo queremos o no
 * 
 * public class cameraShake : MonoBehaviour
{
   public IEnumerator Shake(float duration, float magnitude)
    {
        Vector3 originalPos = transform.localPosition;

        float elapsed = 0f;

        while (elapsed < duration)
        {
            float y = Random.Range(-1f, 1f) * magnitude;
            float x = Random.Range(-1f, 1f) * magnitude;

            transform.localPosition = new Vector3(x, y, originalPos.z);

            elapsed += Time.deltaTime;

            yield return null;
        }

        transform.localPosition = originalPos;
    }
}*/

public class cameraShake : MonoBehaviour
{
    public static cameraShake Instance;
    Vector3 startPos;

    void Awake()
    {
        Instance = this;
    }

    void Start()
    {
        //This will set the starting position 
        startPos = transform.position;
    }

    IEnumerator Shake()
    {
        for (int i = 0; i < 3; i++)
        {
            transform.position = new Vector3(startPos.x + Random.Range(-0.1f, 0.1f), startPos.y + Random.Range(-0.1f, 0.1f), transform.position.z);
            yield return new WaitForSeconds(0.05f);
        }
        transform.position = startPos;
    }

    public void ShakeMe()
    {
        StartCoroutine(Shake());
    }

}
