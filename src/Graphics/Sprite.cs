using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Content;

namespace MonoGame
{
	class Sprite
	{

		private Texture2D texture;
		private Rectangle textureRect;
		/*
			Vertex m_vertices[4];
			const Texture* m_texture;
			IntRect m_textureRect;
		*/

		public Sprite()
		{
		}

		public void SetTexture(ref Texture2D texture, bool resetRect = false)
		{
			if (resetRect) {
				Rectangle newRect = new Rectangle(0, 0, texture.Width, texture.Height);
				SetTextureRect(ref newRect);
			}

			this.texture = texture;

		}
		public void SetTextureRect(ref Rectangle rectangle)
		{
			if (rectangle != this.textureRect)
			{
				this.textureRect = rectangle;
				//UpdatePositions();
				//UpdateTexCoords();
			}
		}

		public void SetColor()
		{
			//this.texture.Bounds.Top
		}

		//===============================================
		public void Initialize()
		{
		}

		public void LoadContent(ref ContentManager content, string textureName, bool resetRect = false)
		{
			Texture2D newTexture = content.Load<Texture2D>(textureName);
			SetTexture(ref newTexture, resetRect);
		}

		public void Update(ref GameTime gameTime)
		{
		}

		public void Draw(ref GameTime gameTime)
		{
		}
	}
}