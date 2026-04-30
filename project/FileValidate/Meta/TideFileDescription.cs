namespace FileValidate.Meta;

public class TideFileDescription : ITideMetaData
{
	// <summary>
	// Identifier of the file
	// </summary>
	public string Identifier { get; set; }

	// <summary>
	// Filename that is referenced, created relative to the executable
	// </summary>
	public string Filename { get; set; }

	// <summary>
	// Size of the file referenced in the metadata
	// </summary>
	public int Size { get; set; }

	// <summary>
	// Number of non-leaf hashes - For Part 3
	// </summary>
	public int HashesCount { get; set; }

	// <summary>
	// List of the hashes given - Should match the hashes count
	// </summary>
	public List<string> Hashes { get; set; }

	// <summary>
	// Number of chunks the file should have
	// </summary>
	public int ChunksCount { get; set; }

	// <summary>
	// List of chunk meta data components
	// </summary>
	public List<ITideChunkMetaData> Chunks { get; set; }	

	public TideFileDescription()
	{
		
	}

	// <summary>
	// Loads a file using the file path itself
	// </summary> 
	public static TideFileDescription FromFilePath(string filepath)
	{
		return null;
	}

	
}
