using UnityEngine;

namespace VisualScoreCounter.VSCounter
{
    internal class VSCounterTweenHelper : MonoBehaviour
    {
        public float animationTime { get; set; } = 0.20f;
        public EaseType easeType { get; set; } = EaseType.InExpo;
    }
}
