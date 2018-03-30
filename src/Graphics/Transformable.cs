using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace MonoGame
{
	class Transformable
	{
		protected Vector2 origin;
		protected Point position;
		protected float rotation;
		protected Vector2 scale;

		public Transformable()
		{
			origin = new Vector2(0.0f,0.0f);
			position = new Point(0,0);
			rotation = 0.0f;
			scale = new Vector2(1.0f,1.0f);
		}

		//===============================================

		public void SetPosition(int x, int y)
		{
			this.position.X = x;
			this.position.Y = y;
			//m_transformNeedUpdate = true;
			//m_inverseTransformNeedUpdate = true;
			Resize();
		}

		public void SetPosition(ref Point position)
		{
			SetPosition(position.X, position.Y);
		}

		public ref Point GetPosition()
		{
			return ref position;
		}

		public void Move(int offsetX, int offsetY)
		{
			SetPosition(position.X + offsetX, position.Y + offsetY);
		}

		public void Move(ref Point offset)
		{
			SetPosition(position.X + offset.X, position.Y + offset.Y);
		}

		//===============================================

		public void SetRotation(float angle)
		{
			this.rotation = angle % 360f;
			if (this.rotation < 0)
				this.rotation += 360f;
			/*
				m_rotation = static_cast<float>(fmod(angle, 360));
				if (m_rotation < 0)
					m_rotation += 360.f;
			*/
			//m_transformNeedUpdate = true;
			//m_inverseTransformNeedUpdate = true;
		}

		public ref float GetRotation()
		{
			return ref rotation;
		}

		public void Rotate(float angle)
		{
			SetRotation(rotation + angle);
		}

		//===============================================

		public void SetScale(float x, float y)
		{
			this.scale.X = x;
			this.scale.Y = y;
			//m_transformNeedUpdate = true;
			//m_inverseTransformNeedUpdate = true;

			Resize();
		}

		public void SetScale(ref Vector2 scale)
		{
			SetScale(scale.X, scale.Y);
		}

		public ref Vector2 GetScale()
		{
			return ref scale;
		}

		public void Scale(float factorX, int factorY)
		{
			SetScale(scale.X + factorX, scale.Y + factorY);
		}

		public void Scale(ref Vector2 factor)
		{
			SetScale(scale.X + factor.X, scale.Y + factor.Y);
		}

		//===============================================

		public void SetOrigin(float x, float y)
		{
			this.origin.X = x;
			this.origin.Y = y;
			//m_transformNeedUpdate = true;
			//m_inverseTransformNeedUpdate = true;

			Resize();
		}
		public void SetOrigin(ref Vector2 origin)
		{
			SetOrigin(origin.X, origin.Y);
		}

		public ref Vector2 GetOrigin()
		{
			return ref origin;
		}

		//===============================================

		public virtual void Resize()
		{
			// Set in inherited class, where the destRect will exist
		}

		//===============================================

		/*
		const Transform& Transformable::getTransform() const
		{
			// Recompute the combined transform if needed
			if (m_transformNeedUpdate)
			{
				float angle  = -m_rotation * 3.141592654f / 180.f;
				float cosine = static_cast<float>(std::cos(angle));
				float sine   = static_cast<float>(std::sin(angle));
				float sxc    = m_scale.x * cosine;
				float syc    = m_scale.y * cosine;
				float sxs    = m_scale.x * sine;
				float sys    = m_scale.y * sine;
				float tx     = -m_origin.x * sxc - m_origin.y * sys + m_position.x;
				float ty     =  m_origin.x * sxs - m_origin.y * syc + m_position.y;

				m_transform = Transform( sxc, sys, tx,
										-sxs, syc, ty,
										0.f, 0.f, 1.f);
				m_transformNeedUpdate = false;
			}

			return m_transform;
		}


		////////////////////////////////////////////////////////////
		const Transform& Transformable::getInverseTransform() const
		{
			// Recompute the inverse transform if needed
			if (m_inverseTransformNeedUpdate)
			{
				m_inverseTransform = getTransform().getInverse();
				m_inverseTransformNeedUpdate = false;
			}

			return m_inverseTransform;
		}
		*/
	}
}