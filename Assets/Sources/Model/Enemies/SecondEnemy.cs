using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Asteroids.Model
{
    public class SecondEnemy : Enemy
    {
        private readonly float _speed;
        private readonly GameObject _target;

        public SecondEnemy(GameObject target, Vector2 position, float speed) : base(position, 0)
        {
            _target = target;
            _speed = speed;
        }

        public override void Update(float deltaTime)
        {
            Vector2 nextPosition = Vector2.MoveTowards(Position, new Vector2(_target.transform.position.x, _target.transform.position.y), _speed * deltaTime);
            MoveTo(nextPosition);
            LookAt(new Vector2(_target.transform.position.x, _target.transform.position.y));
        }

        private void LookAt(Vector2 point)
        {
            Rotate(Vector2.SignedAngle(Quaternion.Euler(0, 0, Rotation) * Vector3.up, (Position - point)));
        }


    }

    
}
