/*
 *
 *	Adventure Creator
 *	by Chris Burton, 2013-2026
 *	
 *	"DocumentInstance.cs"
 * 
 *	This script stores data related to a Document at runtime, allowing it to be modified wihout affecting the original asset.
 * 
 */

using System.Collections.Generic;
using UnityEngine;

namespace AC
{

	/** Stores data related to a Document at runtime */
	public class DocumentInstance
	{

		#region Variables

		/** The linked Document */
		public readonly Document Document;
		/** The index number of the page last shown */
		public int lastOpenPage = 1;
		/** If True, the Document has been read by the Player */
		public bool hasBeenViewed;
		
		public readonly HashSet<int> HiddenIndices = new();
		private readonly Dictionary<int, PageTextureOverride> textureOverrideDict;

		#endregion


		#region Constructors

		/** A Constructore that assigns the Document directly */
		public DocumentInstance (Document document)
		{
			Document = document;
			lastOpenPage = 1;
			hasBeenViewed = false;
			textureOverrideDict = new Dictionary<int, PageTextureOverride> ();
			HiddenIndices = new();
			if (document != null)
			{
				for (int i = 0; i < document.pages.Count; i++)
				{
					if (document.pages[i].isHiddenByDefault) HiddenIndices.Add(i);
				}
			}
			
			if (Document == null) ACDebug.LogWarning ("Invalid Document");
			else if (!KickStarter.inventoryManager.IsInDocumentsCategory (Document.binID)) Document.binID = KickStarter.inventoryManager.GetFirstDocumentsCategoryID ();
		}


		/** A Constructore that assigns the Document based on its ID in the Inventory Manager */
		public DocumentInstance (int id)
		{
			Document = KickStarter.inventoryManager ? KickStarter.inventoryManager.GetDocument (id) : null;
			textureOverrideDict = new Dictionary<int, PageTextureOverride> ();
			lastOpenPage = 1;
			hasBeenViewed = false;
			HiddenIndices = new();
			if (Document != null)
			{
				for (int i = 0; i < Document.pages.Count; i++)
				{
					if (Document.pages[i].isHiddenByDefault) HiddenIndices.Add(i);
				}
			}
			
			if (Document == null) ACDebug.LogWarning ("Invalid Document with ID " + id	);
			else if (!KickStarter.inventoryManager.IsInDocumentsCategory (Document.binID)) Document.binID = KickStarter.inventoryManager.GetFirstDocumentsCategoryID ();
		}

		#endregion


		#region PublicFunctions
		
		public List<JournalPage> GetVisiblePages()
		{
			List<JournalPage> visiblePages = new();
			for (int i = 0; i < Document.pages.Count; i++)
			{
				if (HiddenIndices.Contains(i)) continue;
				visiblePages.Add(Document.pages[i]);
			}
			return visiblePages;
		}

		/** 
		 * <summary>Gets the texture associated with a given page.  This can be overridden with SetPageTexture.</summary> 
		 * <param name = "pageNumber">The number of the page, starting from 1</param>
		 * <returns>The page's texture</returns>
		 */
		public Texture2D GetPageTexture (int pageNumber)
		{
			PageTextureOverride pageTextureOverride = null;
			if (textureOverrideDict.TryGetValue (pageNumber, out pageTextureOverride))
			{
				return pageTextureOverride.texture;
			}

			return Document.pages[pageNumber].texture;
		}


		/** 
		 * <summary>Sets the texture associated with a given page.  This will override the default.</summary> 
		 * <param name = "pageNumber">The number of the page, starting from 1</param>
		 * <param name = "texture">The page's new texture.  If null, it will revert to its default texture</param>
		 */
		public void SetPageTexture (int pageNumber, Texture2D texture)
		{
			PageTextureOverride pageTextureOverride = null;
			if (!textureOverrideDict.TryGetValue (pageNumber, out pageTextureOverride))
			{
				pageTextureOverride = new PageTextureOverride (pageNumber);
				textureOverrideDict.Add (pageNumber, pageTextureOverride);
			}

			if (texture != null)
			{
				pageTextureOverride.texture = texture;
			}
			else
			{
				textureOverrideDict.Remove (pageNumber);
			}
		}

		#endregion


		#region StaticFunctions

		public static bool IsValid (DocumentInstance documentInstance)
		{
			if (documentInstance != null && documentInstance.Document != null)
			{
				return true;
			}
			return false;
		}

		#endregion


		#region GetSet

		/** The linked Document's ID, or -1 if invalid */
		public int DocumentID { get { return Document != null ? Document.ID : -1; } }
		/** The linked Document's category ID, or -1 if invalid */
		public int CategoryID { get { return Document != null ? Document.binID : -1; } }
		
		public string HiddenIndicesData
		{
			get
			{
				System.Text.StringBuilder data = new System.Text.StringBuilder ();
				foreach (var index in HiddenIndices)
				{
					data.Append(index).Append(")");
				}
				if (HiddenIndices.Count > 0)
				{
					data.Remove (data.Length-1, 1);
				}
				return data.ToString();
			}
			set
			{
				string[] chunks = value.Split(")");
				HiddenIndices.Clear();
				foreach (var chunk in chunks)
				{
					if (int.TryParse(chunk, out int index))
					{
						HiddenIndices.Add(index);
					}
				}
			}
		}

		#endregion


		#region PrivateFunctions

		private class PageTextureOverride
		{

			public readonly int Number;
			public Texture2D texture;

			public PageTextureOverride (int number)
			{
				Number = number;
			}

		}

		#endregion

	}

}