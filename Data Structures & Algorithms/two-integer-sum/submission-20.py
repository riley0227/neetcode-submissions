class Solution:
    def twoSum(self, nums: List[int], target: int) -> List[int]:
        numIndecies = defaultdict(int)
        for i in range(len(nums)):
            compliment = target - nums[i]
            if compliment in numIndecies:
                return [numIndecies[compliment], i]
            numIndecies[nums[i]] = i

        return []