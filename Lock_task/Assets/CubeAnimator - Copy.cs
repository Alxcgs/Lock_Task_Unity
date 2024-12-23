using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class CubeAnimator : MonoBehaviour
{
    [SerializeField] private float rotationDuration = 1f;
    [SerializeField] private Ease rotationEase = Ease.InOutQuad;
    [SerializeField] private float punchScaleDuration = 1f;
    [SerializeField] private Vector3 punchScaleAmount = new Vector3(1f, 1f, 1f);
    [SerializeField] private Ease punchScaleEase = Ease.InOutQuad;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            Debug.Log("<color=red>Кнопка 1</color>: <color=green>Поворот об'єкта на 360 градусів</color>");
            transform.DORotate(new Vector3(0, 360, 0), rotationDuration, RotateMode.FastBeyond360)
                .SetEase(rotationEase);
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            Debug.Log("<color=red>Кнопка 2</color>: <color=green>Анімація Punch Scale</color>");
            transform.DOPunchScale(punchScaleAmount, punchScaleDuration)
                .SetEase(punchScaleEase);
        }
    }
}


