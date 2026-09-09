class Solution:
    def twoSum(self, nums: List[int], target: int) -> List[int]:
        vals = {}

        for i in range(len(nums)):
            compliment = target - nums[i]
            if compliment in vals:
                return [vals[compliment], i]
            vals[nums[i]] = i

        return []