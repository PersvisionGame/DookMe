using UnityEngine;
using UnityEngine.EventSystems;

public class ButtonClickSound : MonoBehaviour, IPointerDownHandler
{
    public AudioSource audioSource;

    public void OnPointerDown(PointerEventData eventData)
    {
        audioSource.Play();
    }
}
