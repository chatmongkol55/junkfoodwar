using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject draggingObject;
    public GameObject currentContainer;

    public static GameManager instance;

    private void Awake()
    {
        instance = this;
    }

    public void PlaceObject()
    {
        if (draggingObject != null && currentContainer != null)
        {
            GameObject objectGame = Instantiate(draggingObject.GetComponent<ObjectDragging>().card.object_Game, currentContainer.transform);
            objectGame.GetComponent<PlantController>().human = currentContainer.GetComponent<ObjectContainer>().spawnPoint.human;
            currentContainer.GetComponent<ObjectContainer>().isFull = true;
        }
    }
}
