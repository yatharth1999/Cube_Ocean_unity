using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class physicsAndinputs : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public List<physicsandinput> CubeEntityphysics ;
    // Update is called once per frame
    void Update()
    {
        processInput();
    }
    public physicsandinput SelectedEntity;
    public int SelectedEntityIndex;
     public float deltaPosition = 1;
    void processInput(){
        if(Input.GetKey(KeyCode.LeftArrow))
            SelectedEntity.velocity.x -= deltaPosition;
        if(Input.GetKey(KeyCode.RightArrow))
            SelectedEntity.velocity.x += deltaPosition;
        if(Input.GetKey(KeyCode.UpArrow))
            SelectedEntity.velocity.z += deltaPosition;
        if(Input.GetKey(KeyCode.DownArrow))
            SelectedEntity.velocity.z -= deltaPosition;
        if(Input.GetKey(KeyCode.PageUp))
            SelectedEntity.velocity.y += deltaPosition;
        if(Input.GetKey(KeyCode.PageDown))
            SelectedEntity.velocity.y -= deltaPosition;
        if(Input.GetKey(KeyCode.Space))
        {
            SelectedEntity.velocity = Vector3.zero;
        }
        if(Input.GetKeyUp(KeyCode.Tab))
            SelectedNextEntity();
    }
    void SelectedNextEntity()
    {   
        UnselectAll();
        if (SelectedEntityIndex >= CubeEntityphysics.Count-1)
        {
            SelectedEntityIndex = 0;
        }
        else 
        {
            SelectedEntityIndex += 1;
        }
        SelectedEntity = CubeEntityphysics[SelectedEntityIndex];
        SelectedEntity.isSelected = true;
    }                   
    void UnselectAll ()
    {
        foreach(physicsandinput ph in CubeEntityphysics)
        {
            ph.isSelected = false;
        }
    }
}
