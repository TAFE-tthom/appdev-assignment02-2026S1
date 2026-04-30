namespace FileValidate.Core;


public interface MerkleTree : IMerkleTreeObject
{

	// <summary>
	// Creates a merkle tree object from the file and metadata associated
	// with the file
	// </summary>
	public IMerkleTreeObject? FromFile(ITideFileFormat file) {
		return null;
	}
	

	// <summary>
	// Gets the left subtree from the root of the tree
	// If it is a leaf node, it should return null
	// </summary>
	public IMerkleTreeObject? GetLeftSubTree() {
		return null;
	}


	// <summary>
	// Gets the right subtree from the root of the tree
	// If it is a leaf node, it should return null
	// </summary>
	public IMerkleTreeObject? GetRightSubTree() {
		return null;
	}

	// <summary>
	// Lists all the expected hashes (not computed)
	// that are within the file.
	// </summary>
	public List<string> AllExpectedHashes() {
		return new List<string>();
	}

	// <summary>
	// The list of hashes represented as strings that should represent
	// the completion state.
	//
	// 
	// Examples using a file with 4 chunks and 7 nodes (3 non-leaf nodes):
	//   1. If the file is complete, the root hash is return
	//   2. If the file's first two chunks are complete, the root's left child is returned
	//   3. If we have the first and last chunk complete, the first and last chunk hashes would be returned
	//   4. If the last half of the file is completed, the has of the root's right child is returned.
	// </summary>
	public List<string> MinimumSetOfHashes_RepresentingCompletion() {
		return new List<string>();
	}


	// <summary>
	// Retrieves the data that corresponds to the hash specified.
	//   1. If the hash corresponds to a leaf node, this will simply return the data related to that node
	//   2. If the hash corresponds to a non-leaf node,
	//          this will return the data of all leaf nodes within that subtree
	// 
	// </summary>
	public List<byte> DataFromFromHash(string hash) {

		return new List<byte>();
	}

	
	
}
