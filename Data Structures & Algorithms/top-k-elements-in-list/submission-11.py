class Solution:
    def topKFrequent(self, nums: List[int], k: int) -> List[int]:
        numberCounts = defaultdict(int)

        for n in nums:
            numberCounts[n] += 1

        result = sorted(numberCounts, key = numberCounts.get, reverse = True)

        return result[:k]

        


