from termcolor import colored


class tree_creator:
    def __init__(self, size=10, has_pot=False):
        self.size = size
        self.has_pot = has_pot

    def create_tree(self):
        self.print_tree()
        if self.has_pot:
            self.print_pot()
        else:
            self.print_trunk()

    def print_tree(self):
        spaces = self.size

        for count in range(self.size + 1):
            self.print_spaces(spaces)
            spaces -= 1
            self.print_tree_left(count)
            self.print_tree_right(count)
            print()

    def print_tree_left(self, width):
        for count in range(width):
            print(colored("*", "green"), end="")

    def print_tree_right(self, width):
        for count in range(width):
            print(colored("*", "green"), end="")

    def print_spaces(self, amount):
        for count in range(amount):
            print(" ", end="")

    def print_pot(self):
        spaces = self.size - 1
        self.print_spaces(spaces)
        print(colored("**", "yellow"))

        spaces = self.size - 3
        self.print_spaces(spaces)
        print(colored("******", "magenta"))
        self.print_spaces(spaces)
        print(colored("******", "magenta"))

    def print_trunk(self):
        spaces = self.size - 1
        for count in range(3):
            self.print_spaces(spaces)
            print(colored("**", "yellow"))
