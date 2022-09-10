using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StoneController : MonoBehaviour
{
    Material _myMaterialA;
    Material _myMaterialB;
    [SerializeField] Material _material;
    [SerializeField] MeshRenderer _topStone;
    [SerializeField] MeshRenderer _underStone;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void SetColler(bool isUpFace)
    {
        if(_myMaterialA = null)
        {
            _myMaterialA = Instantiate<Material>(_material);
            _myMaterialB = Instantiate<Material>(_material);
            _topStone.material = _myMaterialA;
            _underStone.material = _myMaterialB;
        }
        _myMaterialA.color = isUpFace ? Color.white : Color.black;
        _myMaterialB.color = isUpFace ? Color.black : Color.white;
    }
    public void SetState(StonesState stonesState)
    {
        bool isActive = (stonesState != StonesState.None);
        {
            _topStone.gameObject.SetActive(isActive);
            _underStone.gameObject.SetActive(isActive);
        }
        SetColler(stonesState == StonesState.Face);
    }
    
}
