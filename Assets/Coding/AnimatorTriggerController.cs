using UnityEngine;

public class AnimatorTriggerController : MonoBehaviour
{

    // set trigger name on inspector
    public string triggerName = "SwitchTrigger";

    private Animator _animator;

    void Awake()
    {
        _animator = GetComponent<Animator>();

       
        if (_animator != null)
        {
            _animator.enabled = false;
        }
    }

   
    public void ActivateAndTrigger()
    {
        if (_animator == null) return;

       
        _animator.enabled = true;

       
        if (!string.IsNullOrEmpty(triggerName))
        {
            _animator.SetTrigger(triggerName);
        }

    }
}
