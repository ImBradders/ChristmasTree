from treecreator import TreeCreator
from termcolor import colored
import random

class ChristmasTreeCreator(TreeCreator):
    def __init__(self, size=10, has_pot=False, bauble_percentage=10):
        self.bauble_percentage = bauble_percentage
        super().__init__(size=size, has_pot=has_pot)

    def print_tree_half(self, width):
        for count in range(width):
            if random.randint(0, 100) <= self.bauble_percentage:
                print(colored("*", "red"), end="")
            else:
                print(colored("*", "green"), end="")