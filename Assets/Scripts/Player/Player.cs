using UnityEngine;


public class Player : MonoBehaviour
{
    [SerializeField] public float _stepSize;
    [SerializeField] private float _minHeigth;
    [SerializeField] private float _maxHeigth;
    [SerializeField] public int _score;
   


    private PlayerInput _playerInput;
    private Vector2 _targetPos;
   







    private void Awake()
    {
        _playerInput= new PlayerInput();
        _playerInput.Active.Up.performed += context => MoveUp();
        _playerInput.Active.Down.performed += context => MoveDown();
    }

    private void OnEnable()
    {
        _playerInput.Active.Enable();
    }
    private void OnDisablee()
    {
        _playerInput.Active.Disable();
    }


    private void MoveUp()
    {

        if(transform.position.y < _minHeigth)
        {
            _targetPos = new Vector2(transform.position.x, transform.position.y + _stepSize);
            transform.position = _targetPos;
            Debug.Log("Up");
        }

    }

    private void MoveDown()
    {

        if(transform.position.y > _maxHeigth)
        {
            _targetPos = new Vector2(transform.position.x, transform.position.y - _stepSize);
            transform.position = _targetPos;
            Debug.Log("Down");
        }

    }


}
