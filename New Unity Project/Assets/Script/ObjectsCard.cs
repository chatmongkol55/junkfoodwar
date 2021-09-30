using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ObjectsCard : MonoBehaviour, IDragHandler,IPointerDownHandler,IPointerUpHandler
{
    public GameObject object_Drag;
    public GameObject object_Game;
    public Canvas canvas;
    private GameObject ObjectDragInstance;
    private GameManager gameManager;

    private void Start()
    {
        gameManager = GameManager.instance;
    }
    public void OnDrag(PointerEventData eventData)
    {
        ObjectDragInstance.transform.position = Input.mousePosition;
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        ObjectDragInstance = Instantiate(object_Drag, canvas.transform);
        ObjectDragInstance.transform.position = Input.mousePosition;
        ObjectDragInstance.GetComponent<ObjectDragging>().card = this;

        gameManager.draggingObject = ObjectDragInstance;
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        gameManager.PlaceObject();
        gameManager.draggingObject = null;
        Destroy(ObjectDragInstance);
    }
}
