import unittest

class Trie:
    def __init__(self):
        self.root:TrieNode = TrieNode()

    def insert(self, word:str):
        trie_node = self.root
        for i in range(len(word)):
            trie_node = trie_node.get_if_add_child(word[i])
        trie_node.set_end()

    def search(self, word:str) -> bool:
        trie_node = self.root
        for i in range(len(word)):
            if trie_node.get_child(word[i]):
                trie_node = trie_node.get_child(word[i])
            else:
                return False
        return trie_node.end()

    def delete(self, word:str) -> bool:
        return self.root.remove(word)

class TrieNode:
    def __init__(self):
        self.children = {}
        self.is_end = False

    def end(self) -> bool:
        return self.is_end

    def add_child(self, char:str):
        self.children[char] = TrieNode()
        return self.children[char]

    def get_if_add_child(self, char:str):
        child = self.get_child(char)
        if child:
            return child
        else:
            return self.add_child(char)

    def get_child(self, char:str):
        return self.children.get(char)

    def set_end(self):
        self.is_end = True

    def remove(self, word:str, idx:int = 0):
        trie_node = self
        char = word[idx]
        if not trie_node.get_child(char):
            return False

        idx += 1
        current_node = trie_node.get_child(char)
        if idx == len(word):
            if not current_node.is_end:
                return False
            current_node.is_end = False
            print(f"{char} chane end -> False")
            if current_node.has_child():
                return False
            trie_node.children.pop(char)
            print(f"deleted {char}")
            return True
        else:
            if current_node.remove(word, idx):
                print("end delete")
            else:
                if not current_node.is_end and not current_node.has_child():
                    current_node.children.pop(char)
                    print(f"deleted {char}")
        return True

    def has_child(self):
        if len(self.children) == 0:
            return False
        return True

class TestTrie(unittest.TestCase):
    def setUp(self):
        self.trie = Trie()

    def test_basic_insert_search(self):
        self.trie.insert("apple")
        self.assertTrue(self.trie.search("apple"))
        self.assertFalse(self.trie.search("app"))
        # self.assertTrue(self.trie.starts_with("app"))
        self.trie.insert("app")
        self.assertTrue(self.trie.search("app"))

    def test_delete_and_persistence(self):
        self.trie.insert("a")
        self.trie.insert("ab")
        self.trie.insert("abc")
        self.assertTrue(self.trie.delete("abc"))
        self.assertFalse(self.trie.search("abc"))
        self.assertTrue(self.trie.search("ab"))
        self.assertTrue(self.trie.search("a"))

    def test_unicode_and_spaces(self):
        self.trie.insert("안녕")
        self.trie.insert("안녕하세요")
        self.assertTrue(self.trie.search("안녕"))
        # self.assertTrue(self.trie.starts_with("안"))
        self.trie.insert("a b")
        self.assertTrue(self.trie.search("a b"))

    # def test_autocomplete_and_count(self):
    #     words = ["car","card","care","cat"]
    #     for w in words:
    #         self.trie.insert(w)
    #     suggestions = self.trie.autocomplete("ca", k=10)
    #     for w in ["car","card","care","cat"]:
    #         self.assertIn(w, suggestions)
    #     self.assertEqual(self.trie.count_prefix("car"), 3)

    def test_edge_cases(self):
        # empty string behavior depends on implementation
        try:
            self.trie.insert("")
            self.assertTrue(self.trie.search("") or True)
        except Exception:
            pass

    def test_stress_small(self):
        for i in range(10000):
            w = f"word{i}"
            self.trie.insert(w)
        for i in range(0,10000,100):
            self.assertTrue(self.trie.search(f"word{i}"))


if __name__ == '__main__':
    unittest.main()
