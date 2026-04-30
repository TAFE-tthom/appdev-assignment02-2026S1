
namespace FileValidate.Core;

using FileValidate.Meta;

public class TideFile : ITideFileFormat {
	
	// <summary>
	// Constructs an object of the implementing class using the metadata
	// </summary>
	public static ITideFileFormat? WithMetaData(ITideMetaData metadata) {
		return null;
	}

	
	// <summary>
	// Returns the metadata constructed with the file
	// </summary>
	public ITideMetaData? GetMetaData() {
		return null;
	}

	// <summary>
	// Retrieves a chunk, the index corresponds to an index in the TideMetaData object 
	// </summary>
	public ITideChunkMetaData? GetChunkMetaData(int index) {
		return null;
	}

	// <summary>
	// Gets a list of bytes that correspond to the chunk
	// </summary>
	public List<byte> GetChunkData(int index) {

		return new List<byte>();
	}

	// <summary>
	// Writes bytes contained in data to the chunk corresponding to index
	// </summary>
	public void WriteDataToChunk(int index, List<byte> data) {
		
	}

	// <summary>
	// Computes the hash of the chunk referenced by the index
	// Uses SHA256 hash algorithm
	// </summary>
	public string ComputeChunkHash(int index) {
		return string.Empty;
	}


	// <summary>
	// Computes the hash of the chunk given
	// Uses SHA256 hash algorithm
	// </summary>
	public string ComputeChunkHashOnBlock(List<byte> bytes) {
		return string.Empty;
	}


	// <summary>
	// Identifies if the file is complete
	// </summary>
	public bool IsComplete() {
		return false;
	}


	// <summary>
	// Identifies if the file is incomplete
	// </summary>
	public bool IsIncomplete() {
		return false;
	}


	// <summary>
	// Returns a list of completed blocks
	// </summary>
	public List<ITideChunkMetaData> CompletedBlocks() {
		return new List<ITideChunkMetaData>();
	}
	
	// <summary>
	// Returns a list of incompleted blocks
	// </summary>
	public List<ITideChunkMetaData> IncompletedBlocks() {
		return new List<ITideChunkMetaData>();
	}
}
