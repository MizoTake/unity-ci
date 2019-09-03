require 'yaml'

# yaml = YAML.load_file("./src/orbs/unity-ci.yml")

# p yaml["commands"]

data = open('./src/orbs/unity-ci.yml', 'r') { |f| YAML.load(f) }
p data