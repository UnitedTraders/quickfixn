$LOAD_PATH << File.dirname(__FILE__)

require 'rubygems'
require 'fix_dictionary'
require 'fields_gen'
require 'messages_gen'
require 'message_factory_gen'

class Generator  
  def self.generate
    generator = Generator.new
    generator.generate_message_factories
    generator.generate_fields
    generator.generate_messages
  end
  
  def initialize
    @fix40 = FIXDictionary.load spec('FIX40')
    @fix41 = FIXDictionary.load spec('FIX41')
    @fix42 = FIXDictionary.load spec('FIX42')
	@fix42sterling = FIXDictionary.load spec('FIX42Sterling')
	@fix42ib = FIXDictionary.load spec('FIX42InteractiveBrokers')
    @fix43 = FIXDictionary.load spec('FIX43')
    @fix44 = FIXDictionary.load spec('FIX44')
    @fix50 = FIXDictionary.load spec('FIX50')
    @fix50sp1 = FIXDictionary.load spec('FIX50SP1')
    @fix50sp2 = FIXDictionary.load spec('FIX50SP2')
    @src_path = File.join File.dirname(__FILE__), '..', 'QuickFIXn'
    @src_messages_path = File.join File.dirname(__FILE__), '..'
  end

  def spec fixver
    File.join File.dirname(__FILE__), "..", "spec", "fix", "#{fixver}.xml"
  end
    
  def generate_fields
    fields_path = File.join(@src_path, 'Fields', 'Fields.cs')
    tags_path = File.join(@src_path, 'Fields', 'FieldTags.cs')
    FieldGen.generate(agg_fields, fields_path, tags_path)
  end

  def agg_fields
    field_names = (@fix40.fields.keys + @fix41.fields.keys +
        @fix42.fields.keys + @fix42sterling.fields.keys + @fix42ib.fields.keys + @fix43.fields.keys +
        @fix44.fields.keys + @fix50.fields.keys +
        @fix50sp1.fields.keys + @fix50sp2.fields.keys).uniq
    field_names.map {|fn| get_field_def(fn) }
  end

  def get_field_def fld_name
    # we give priority to latest fix version
    fld = merge_field_defs(
      @fix50sp2.fields[fld_name],
      @fix50sp1.fields[fld_name],
      @fix50.fields[fld_name],
      @fix44.fields[fld_name],
      @fix43.fields[fld_name],
	  @fix42ib.fields[fld_name],
	  @fix42sterling.fields[fld_name],
      @fix42.fields[fld_name],
      @fix41.fields[fld_name],
      @fix40.fields[fld_name]
    )
    
    raise "couldn't find field! #{fld}" if fld.nil?
    fld
  end

  def merge_field_defs *alldefs
    defs = alldefs.reject {|d| d.nil?}
    return nil if defs.empty?
    fld = defs.first
    
    vals = defs.map { |d| d[:values] }.reject { |d| d.nil? }.flatten
    return fld if vals.empty?
    vals = vals.inject([]) {|saved, v| saved << v unless saved.detect {|u| u[:desc] == v[:desc]}; saved}
    fld[:values] = vals
    fld
  end

  def generate_messages
    msgs_path = File.join(@src_messages_path, 'Messages')
    MessageGen.generate(@fix40.messages,  msgs_path, 'FIX40', 'FIX40')
    MessageGen.generate(@fix41.messages,  msgs_path, 'FIX41', 'FIX41')
    MessageGen.generate(@fix42.messages,  msgs_path, 'FIX42', 'FIX42')
	MessageGen.generate(@fix42sterling.messages,  msgs_path, 'FIX42Sterling', 'FIX42')
	MessageGen.generate(@fix42ib.messages,  msgs_path, 'FIX42InteractiveBrokers', 'FIX42')
    MessageGen.generate(@fix43.messages,  msgs_path, 'FIX43', 'FIX43')
    MessageGen.generate(@fix44.messages,  msgs_path, 'FIX44', 'FIX44')
    MessageGen.generate(@fix50.messages,  msgs_path, 'FIX50', 'FIXT11')
    MessageGen.generate(@fix50sp1.messages,  msgs_path, 'FIX50SP1', 'FIXT11')
    MessageGen.generate(@fix50sp2.messages,  msgs_path, 'FIX50SP2', 'FIXT11')
  end

  def generate_message_factories
    msgs_path = File.join(@src_messages_path, 'Messages')
    MessageFactoryGen.generate(@fix40.messages,  msgs_path, 'FIX40', 'FIX40')
    MessageFactoryGen.generate(@fix41.messages,  msgs_path, 'FIX41', 'FIX41')
    MessageFactoryGen.generate(@fix42.messages,  msgs_path, 'FIX42', 'FIX42')
	MessageFactoryGen.generate(@fix42sterling.messages,  msgs_path, 'FIX42Sterling', 'FIX42')
	MessageFactoryGen.generate(@fix42ib.messages,  msgs_path, 'FIX42InteractiveBrokers', 'FIX42')
    MessageFactoryGen.generate(@fix43.messages,  msgs_path, 'FIX43', 'FIX43')
    MessageFactoryGen.generate(@fix44.messages,  msgs_path, 'FIX44', 'FIX44')
    MessageFactoryGen.generate(@fix50.messages,  msgs_path, 'FIX50', 'FIX50')
    MessageFactoryGen.generate(@fix50sp1.messages,  msgs_path, 'FIX50SP1', 'FIXT11')
    MessageFactoryGen.generate(@fix50sp2.messages,  msgs_path, 'FIX50SP2', 'FIXT11')
  end
end


Generator.generate
