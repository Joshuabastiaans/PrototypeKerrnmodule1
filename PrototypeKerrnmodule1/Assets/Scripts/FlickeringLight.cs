using UnityEngine;
using System.Collections;

public class FlickeringLight : MonoBehaviour
{
    public float minIntensity = 0.5f;
    public float maxIntensity = 1.5f;
    public float flickerSpeed = 1.0f;

    private Light _light;
    private float _originalIntensity;
    private bool _isFlickering = false;

    private void Start()
    {
        _light = GetComponent<Light>();
        _originalIntensity = .2f;
    }

    private void Update()
    {
        if (!_isFlickering)
        {
            // Start the flicker loop
            StartCoroutine(Flicker());
            _isFlickering = true;
        }
    }

    private IEnumerator Flicker()
    {
        while (true)
        {
            // wait 5 seconds before flickering starts
            yield return new WaitForSeconds(5);
            // Calculate a random intensity between min and max
            float randomIntensity = Random.Range(minIntensity, maxIntensity);

            // Apply the intensity to the light
            _light.intensity = _originalIntensity * randomIntensity;

            // Wait for a random amount of time
            float flickerDuration = Random.Range(0.1f, 0.5f);
            yield return new WaitForSeconds(flickerDuration / flickerSpeed);

            // Restore the original intensity
            _light.intensity = _originalIntensity;

            // Wait for a random amount of time
            yield return new WaitForSeconds(flickerDuration / flickerSpeed);
        }
    }
}
