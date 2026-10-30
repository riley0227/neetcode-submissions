class Solution:
    def hasDuplicate(self, nums: List[int]) -> bool:
        shown = set()
        for n in nums:
            if n in shown:
                return True
            shown.add(n)
        return False