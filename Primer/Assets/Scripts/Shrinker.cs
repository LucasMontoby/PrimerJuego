using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shrinker : MonoBehaviour
{
    private Vector3 _littlePotter = new Vector3(0.25f, 0.25f, 0.25f);
    private Vector3 _normalPotter = new Vector3(1f, 1f, 1f);
    [SerializeField] private float impactTime = 0.35f;
    private float _currentTime;


    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            _currentTime += Time.deltaTime;

            if (other.TryGetComponent<HarryController>(out var harryController))
            {
                if (harryController.transform.localScale == _normalPotter && _currentTime >= impactTime)
                {
                    harryController.transform.localScale = _littlePotter;
                    _currentTime = 0;
                }

                if (harryController.transform.localScale == _littlePotter && _currentTime >= impactTime)
                {
                    harryController.transform.localScale = _normalPotter;
                    _currentTime = 0;
                }
            }
        }
    }
}
